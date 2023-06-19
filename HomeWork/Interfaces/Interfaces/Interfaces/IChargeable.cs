using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otus.HomeWork.Interfaces
{
    public interface IChargeable
    {
        /// <summary>
        /// Метод для зарядки
        /// </summary>
        public void Charge();


        /// <summary>
        /// Получение данных
        /// </summary>
        public string GetInfo();
    }
}
