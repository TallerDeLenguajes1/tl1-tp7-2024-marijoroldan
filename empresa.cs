using System;

namespace AdministracionEmpresa
{
    class Program
    {
        static void Main(string[] args)
        {
            double MontoTotal = 0;
            Empleado E1 = new Empleado();
            Empleado E2 = new Empleado();
            Empleado E3 = new Empleado();
            Empleado EV = null;

            //Carga  Empleado 1 
            E1.Nombre = "Julian";
            E1.Apellido = "Lagarrigue";
            E1.EstadoCivil = 'C';
            E1.FechaDeIngresoAEmpresa = new DateTime(2000, 10, 12);
            E1.FechaDeNacimiento = new DateTime(1975, 03, 02);
            E1.Cargo = Cargos.Ingeniero;
            E1.Genero = 'M';
            E1.SueldoBasico = 100000.00;
            //--------------------------------------------------   

            //Carga  Empleado 2 
            E2.Nombre = "Juana";
            E2.Apellido = "Medina";
            E2.EstadoCivil = 'S';
            E2.FechaDeIngresoAEmpresa = new DateTime(1995, 02, 11);
            E2.FechaDeNacimiento = new DateTime(1980, 07, 02);
            E2.Cargo = Cargos.Especialista;
            E2.Genero = 'F';
            E2.SueldoBasico = 95000.00;
            //--------------------------------------------------      

            //Carga  Empleado 3 
            E3.Nombre = "Florencia";
            E3.Apellido = "Roldan";
            E3.EstadoCivil = 'S';
            E3.FechaDeIngresoAEmpresa = new DateTime(2022, 01, 01);
            E3.FechaDeNacimiento = new DateTime(2000, 03, 02);
            E3.Cargo = Cargos.Auxiliar;
            E3.Genero = 'F';
            E3.SueldoBasico = 65000.00;
            //--------------------------------------------------

            MontoTotal = E1.calcularSalario() + E2.calcularSalario() + E3.calcularSalario();
            Console.WriteLine($"El Monto Total a pagar en concepto de salarios es: ${MontoTotal}");

            if (E1.faltanteJubilacion() < E2.faltanteJubilacion() && E1.faltanteJubilacion() < E3.faltanteJubilacion())
            {
                EV = E1;
            }
            else
            {
                if (E2.faltanteJubilacion() < E1.faltanteJubilacion() && E2.faltanteJubilacion() < E3.faltanteJubilacion())
                {
                    EV = E2;
                }
                else
                {
                    if (E3.faltanteJubilacion() < E1.faltanteJubilacion() && E3.faltanteJubilacion() < E2.faltanteJubilacion())
                    {
                        EV = E3;
                    }
                }
            }

            Console.WriteLine($"El empleado mas proximo a jubilarse es {EV.Apellido}, {EV.Nombre}\nEdad: {EV.edad()} Años con {EV.faltanteJubilacion()} Años Faltantes para jubilarse.\nSalario: ${EV.calcularSalario()} \nAntigüedad: {EV.antiguedad()} Años \n Cargo: {EV.Cargo} \n Genero: {EV.Genero} \n Estado Civil: {EV.EstadoCivil}");

        }
    }
}