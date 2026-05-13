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
        int totalItems=0;

    
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

                Console.WriteLine("=== CATALOGO DISPONIBLE===");
                Console.WriteLine("{0,-5} {1,-15 } {2,-10} ","Id","Productos","Precio");

                    for (int i=0;i<10;i++) //PARA MOSTRAR EL CATALOGO
                    {
                        Console.WriteLine($"{catIds[i],-5} {catNombres[i],-15} {catPrecios[i]:N2}");
                    }

                    Console.WriteLine("Ingrese el ID del producto");
                    int idSelec = int.Parse(Console.ReadLine());
                    bool encontrado = false;

                    for (int i=0;i<10;i++) //UBICA EL PRODUCTO DEL CATALOGO
                    {

                        if(catIds[i] == idSelec) //AÑADE EL PRODUCTO AL CARRITO
                        {
                            Console.WriteLine($"Cuanta cantidad de {carNombres[i]} deseas?");
                            int cant = int.Parse(Console.ReadLine());

                            carIds[totalItems] = catIds[i];
                            carNombres[totalItems]=catNombres[i];
                            carCantidades[totalItems]=cant;
                            carSubtotal[totalItems]=catPrecios[i]*cant;

                            totalItems++;
                            encontrado=true;
                            Console.WriteLine("Producto añadido al carrito");
                            break;

                        }

                    }
                    if (!encontrado)
                    {
                        Console.WriteLine("ID No valido");
                        Console.WriteLine("PRESIONE CUALQUIER PARA CONTINUAR");
                        Console.ReadKey();
                    }

                break;

                case 2:
                        Console.Clear();
                        MostrarCarrito(carIds,carNombres,carCantidades,carSubtotal,totalItems);
                        Console.WriteLine("PRESIONE CUALQUIER TECLA PARA VOLVER");
                        Console.ReadKey();

                break;

                 case 3: //ELIMINAR PRODCUTOS EN EL CARRITO
                    if (totalItems == 0)
                    {
                        Console.WriteLine("Adentro del carrito esta vacio,no hay nada que eliminar");
                        
                    
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("=== SELECCIONE EL PRODUCTO A ELIMINAR ===");
                        MostrarCarrito(carIds,carNombres,carCantidades,carSubtotal,totalItems);

                        Console.WriteLine("INGRESE EL ID DEL PRODCUTO QUE DESEA ELIMINAR");
                        int idElim=int.Parse(Console.ReadLine());
                        bool eliminado=false;

                        for(int i = 0; i < totalItems; i++)
                        {

                            if (carIds[i] == idElim)
                            {
                                for(int j=i;j<totalItems - 1; j++) //Algoritmo de desplazamiento hacia la izquierda
                                {
                                    carIds[j]=carIds[j+1];
                                    carNombres[j]=carNombres[j+1];
                                    carCantidades[j]=carCantidades[j+1];
                                    carSubtotal[j]=carSubtotal[j+1];
                                }   
                                totalItems--; //Reducimos el contador global                            
                                eliminado=true;
                                Console.WriteLine("PRODUCTO ELIMINADO EXITOSAMENTE");
                                break;
                            }
                        }
                        if(!eliminado)
                        {
                            Console.WriteLine("EL ID INGRESADO NO SE ENCUENTRA EN EL CARRITO");
                        }
                    }
                    Console.WriteLine("PRESIONE CUALQUIER TECLA PARA VOLVER");
                    Console.ReadKey();
                break;

                case 4:
                break;

                case 5:
                flag = false; 
                break;
            }
        }

    }
    static void MostrarCarrito(int[] ids, string[] nombres, int[] cants, double[] subs, int total) 
    {
      if(total==0)
      {
        Console.WriteLine("carro vacio");

        
      }
        else
        {
            Console.WriteLine("{0,-5} {1,-15 } {2,-10} {3,-10} ","Id","Productos","Cantidad","Subtotal");
            for (int i=0;i<total;i++)
            {
                Console.WriteLine($"{ids[i],-5} {nombres[i],-15} {cants[i],-10} $/{subs[i]:N2}");
            }
        }
}
}

 
