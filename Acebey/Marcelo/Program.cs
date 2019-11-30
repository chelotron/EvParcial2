using System;

namespace Marcelo
{
    // class Program
    //  {
    //    static void Main(string[] args)
    //  {
    //    Console.WriteLine("Hello World!");
    //}
    // }
    public class Company
    {
    private string _name;
    private double _saveproject;

    static void Main()
        {

        }

    public string Name { get { return _name; } }
    public double SaveProject { get { return _saveproject; } }

    public Company(string name, double saveproject) { 

            _name = name; 
            _saveproject = saveproject;
}

        //Testeado
    public void Save(double save) {

        _saveproject += save;

    }
        //Testeado, habia un error en esta seccion del codigo
        //public void Spend(double save) { _saveproject += save; } 
        //El de arriba era el codigo original
        //Es un metodo de gasto (SPEND) por lo tanto deberia debitar
        //Tenia un signo "+" se lo cambio por un signo "-"
        public void Spend(double save) {

        _saveproject -= save;

    }
        //Testeado
    public void ChangeName(string name) {

        _name = name;

    }
}


}
