using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otus.HomeWork.QuadraticEquatio
{
    /// <summary>
    /// Класс предоставления объекта ошибки
    /// </summary>
    public class MessageError
    {
        /// <summary>
        /// Параметры ошибки
        /// </summary>
        public Dictionary<string, string> Data { get; set; }

        /// <summary>
        /// Сообщение об ошибке
        /// </summary>
        public string? Message { get; set; }

        public MessageError(Dictionary<string, string> data, string message)
        {
            Data = data;
            Message = message;
        }
    }
}
