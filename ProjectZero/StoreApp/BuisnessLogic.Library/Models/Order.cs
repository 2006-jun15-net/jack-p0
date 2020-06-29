using BusinessLogic.Library.Models;
using DataAccess.Library;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;

namespace BusinessLogic.Library

{
    struct Order
    //Goal: I want to implement a dictionary that contains a key and the value being a list of the Order objects
    //I want to create a dictionary so I can search for the orders by their "key"
    //Question: is it possible to have a key with multiple values associated with it?
    {



        public string CustomerId { get; set;  }

        public string orderID { get; set; }

   
        public List<OrderItem> ItemsList { get; set; } 

        //public List<Review> Reviews { get; set; } = new List<Review>();


    }
}


        //public class OrderList 
        //{
        //        List<Order> Orders = new List<Order> { new Order(custid, orderid, items }




        //}


      

    
    //        { 



    //   try
    //        {
    //            orders.Add("txt", "winword.exe");
    //    }
    //        catch (ArgumentException)
    //        {
    //            Console.WriteLine("An element with Key = \"txt\" already exists.");
    //        }






    //            }
    //}






