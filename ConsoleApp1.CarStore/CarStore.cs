using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CarStore
{
    class CarStore
    {
        public string brand;
        public string model;
        public string city;
        public int graduitionYear;
        public string banType;
        public string color;
        public double engine;
        public int enginePower;
        public string fuelType;
        public int kmRate;
        public string gearbox;
        public string transmitter;
        public string situation;
        public double price;

        public string GetInfo()
        {
            string output = $"brand: {brand}\n" +
                $"model: {model}\n" +
                $"city: {city}\n" +
                $"year: {graduitionYear}\n" +
                $"bantype: {banType}\n" +
                $"color: {color}\n" +
                $"engine: {engine}l \n" +
                $"engine power{enginePower} hp \n" +
                $"fuel type: {fuelType}\n" +
                $"km rate: {kmRate} km \n" +
                $"gearbox: {gearbox}\n" +
                $"transmitter: {transmitter}\n" +
                $"situation: {situation}\n" +
                $"price: {price}€";
            return output;
        }
    }




























}


      

