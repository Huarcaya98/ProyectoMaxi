using System;

class  Program
{
    static void Main(string[] args)
    {
         //ARREGLO DE PRODUCTOS--cat=categoria
        int[] catIds={1,2,3,4,5,6,7,8,9,10};
        string[] catNombres={"Aceite","Arroz","Azucar","Fideos","Leche","Atun","Cafe","Huevos","Lentejas","Papel"};
        double[] catPrecios={120.50,130.00,95.50,62.00,72.00,250.00,98.00,125.00,180.00,100.00};

        //ARREGLO DEL CARRITO--car=carrito
        int[] carIds=new int[50];
        string[] carNombres=new string[50];
        double[] carSubtotal=new double[50];
        int[] carCantidades= new int[50];

    
        Console.WriteLine("Base Main - Proyecto");

        bool flag = true;

        while(flag)
        {
            Console.WriteLine("--- SISTEMA DE VENTAS ---");
            Console.WriteLine("1. Ver Catálogo y Comprar");
            Console.WriteLine("2. Ver Carrito");
            Console.WriteLine("3. Eliminar Producto del Carrito");
            Console.WriteLine("4. Pagar y Generar Voucher");
            Console.Write("Seleccione una opción: ");   

            int option = int.Parse(Console.ReadLine());

            switch(option)
            {
                case 1:
                break;

                case 2:
                break;

                case 3:
                break;

                case 4:
                break;

                case 5:
                flag = false; 
                break;
            }
        }

    }
    
}

 
