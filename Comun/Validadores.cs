using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Validadores
{
    public static bool Validador_Numero(char e)
    {
        string CaracteresPermitidos = "0123456789\b"; //estos son los caracteres permitidos
        bool Existe = CaracteresPermitidos.Contains(e); //variable que comprobará si el caracter es permitido

        if (Existe == true)
        {
            return false; //permite escribir el caracter en la text_box
        }
        else
        {
            return true; //no permite escribir el caracter en la text_box
        }
    }

    public static bool Validador_Telefono(char e)
    {
        string CaracteresPermitidos = "0123456789-\b"; //estos son los caracteres permitidos
        bool Existe = CaracteresPermitidos.Contains(e); //variable que comprobará si el caracter es permitido

        if (Existe == true)
        {
            return false; //permite escribir el caracter en la text_box
        }
        else
        {
            return true; //no permite escribir el caracter en la text_box
        }
    }

    public static bool Validador_Alfanumerico(char e)
    {
        string CaracteresPermitidos = "0123456789 abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZáéíóúÁÉÍÓÚ.,-\b"; //estos son los caracteres permitidos
        bool Existe = CaracteresPermitidos.Contains(e); //variable que comprobará si el caracter es permitido

        if (Existe == true)
        {
            return false; //permite escribir el caracter en la text_box
        }
        else
        {
            return true; //no permite escribir el caracter en la text_box
        }
    }

    public static bool Validador_Alfabetico(char e)
    {
        string CaracteresPermitidos = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZáéíóúÁÉÍÓÚ \b"; //estos son los caracteres permitidos
        bool Existe = CaracteresPermitidos.Contains(e); //variable que comprobará si el caracter es permitido

        if (Existe == true)
        {
            return false; //permite escribir el caracter en la text_box
        }
        else
        {
            return true; //no permite escribir el caracter en la text_box
        }
    }

}
