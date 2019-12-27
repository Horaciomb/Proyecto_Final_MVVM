using System;
using System.Collections.Generic;
using System.Text;

namespace AppPhone.Models
{
    public class Response
    {
        public bool IsSuccess { get; set; } //True o False dependiendo si funcionó o no
        public string Message { get; set; }//Un mensaje si funcionó o no, para mostrar el error
        public object Result { get; set; }// En este objeto llega el modelo [Contact]
    }
}
