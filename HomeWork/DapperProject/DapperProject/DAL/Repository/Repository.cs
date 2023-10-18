using Dapper;
using Otus.HomerWork.DapperProject.DAL.Ineterface;
using Npgsql;
using System.Reflection;
using System.Text.Json.Serialization;
using static Dapper.SqlMapper;

namespace Otus.HomerWork.DapperProject.DAL.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly NpgsqlConnection _connection;

        public Repository(NpgsqlConnection connection) 
        {
            _connection = connection;
        }

        public TEntity? Get(int id) => 
            _connection.QueryFirstOrDefault<TEntity>($@"
                SELECT * 
                FROM {typeof(TEntity).Name.ToLower()}s 
                WHERE id=@id", new { id }
        );

        public IEnumerable<TEntity>? Like(string key, string pattern) =>
            _connection.Query<TEntity>($@"
                SELECT * 
                FROM {typeof(TEntity).Name.ToLower()}s
                WHERE {key} like '%{pattern}%'"
            );

        public IEnumerable<TEntity> GetAll() =>
            _connection.Query<TEntity>($@"
                SELECT * 
                FROM {typeof(TEntity).Name.ToLower()}s"
            );

        public void Add(TEntity entity)
        {
            var properties = typeof(TEntity).GetProperties().Where(item => item.Name != "Id").ToList();
            var propertiesCollection = new List<string>();

            foreach (var property in properties)
            {
                propertiesCollection.Add(property.GetCustomAttribute<JsonPropertyNameAttribute>().Name);
            }

            _connection.Execute($@"
                INSERT INTO {typeof(TEntity).Name.ToLower()}s ({string.Join(", ", propertiesCollection)})
                VALUES ({string.Join(", ", properties.Select(item => "@" + item.Name))})", entity);
        }
    }
}
