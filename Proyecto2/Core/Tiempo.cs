﻿using System;
using System.Text;
using System.Xml.Linq;

namespace Proyecto2.Core
{
    public class Tiempo
    {
        public int Minutos { get; set; }
        public int Segundos { get; set; }

        public Tiempo(int minutos,int segundos)
        {
           if (segundos >59)
            {
                this.Minutos = minutos + segundos / 60;
                this.Segundos = segundos % 60;
            }
            else
            {
                this.Minutos = minutos;
                this.Segundos = segundos;
            }
        }

        public override String ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append("00:").Append(this.Minutos).Append(":").Append(this.Segundos).Append("\n");
            return str.ToString();
        }
        
        //CONVIERTE LOS ATRIBUTOS Minutos Y Segundos A ELEMENTOS XML
        public XElement toXML()
        {
            XElement toRet = new XElement("Tiempo",
                new XElement("Minutos",Minutos),
                new XElement("Segundos", Segundos));

            return toRet;
        }
    }
}
