using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace IBFree.Models
{
    public class BadFoodsInitializer : DropCreateDatabaseIfModelChanges<IBFreeContext>
    {

        protected override void Seed(IBFreeContext context)
        {
             List<BadFood> BadFood = new List<BadFood>
             
            {
                new BadFood {Id = 1,Name = "Apple", Fructan = false, Sorbitol = true, Mannitol = false, Fructose = true, GOS = false, Lactose = false,FoodChallenge = false, Image = "~/Content/Images/Apple.png"},
                new BadFood {Id = 2,Name = "Apricot", Fructan = true, Sorbitol = true, Mannitol = false, Fructose = false, GOS = false, Lactose = false,FoodChallenge = false, Image = "~/Content/Images/Apricot.png"},
                new BadFood {Id =3, Name = "Blackberry", Fructan = false, Sorbitol = true, Mannitol = false, Fructose = false, GOS = false, Lactose = false,FoodChallenge = true, Image = "~/Content/Images/Blackberry.png"},
                new BadFood {Id= 4, Name = "Boysenberry", Fructan = false, Sorbitol = true, Mannitol = false, Fructose = false, GOS = false, Lactose = false,FoodChallenge = true, Image = "~/Content/Images/Boysenberry.png"},
                new BadFood {Id =5, Name = "Coconut", Fructan = false, Sorbitol = true, Mannitol = false, Fructose = false, GOS = false, Lactose = false,FoodChallenge = true, Image = "~/Content/Images/Coconut.png"},
                new BadFood {Id =6, Name = "Cherry", Fructan = false, Sorbitol = true, Mannitol = false, Fructose = true, GOS = false, Lactose = false,FoodChallenge = false, Image = "~/Content/Images/Cherry.png"},
                new BadFood {Id =7, Name = "Fig (Fresh)", Fructan = false, Sorbitol = false, Mannitol = false, Fructose = true, GOS = false, Lactose = false,FoodChallenge = true, Image = "~/Content/Images/FigFresh.png"},
                new BadFood {Id =8, Name = "Fig (Dried)", Fructan = true, Sorbitol = false, Mannitol = false, Fructose = false, GOS = false, Lactose = false,FoodChallenge = true, Image = "~/Content/Images/FigDry.png"},
                new BadFood {Id =9, Name = "Grapefruit", Fructan = true, Sorbitol = false, Mannitol = false, Fructose = false, GOS = false, Lactose = false,FoodChallenge = true, Image = "~/Content/Images/Grapefruit.png"},
                new BadFood {Id =10,Name = "Lychee", Fructan = false, Sorbitol = true, Mannitol = false, Fructose = false, GOS = false, Lactose = false,FoodChallenge = true, Image = "~/Content/Images/Lychee.png"},
                new BadFood {Id =11,Name = "Mango", Fructan = false, Sorbitol = false, Mannitol = false, Fructose = true, GOS = false, Lactose = false,FoodChallenge = true, Image = "~/Content/Images/Mango.png"},
                new BadFood {Id =12,Name = "Nectarine", Fructan = true, Sorbitol = true, Mannitol = false, Fructose = false, GOS = false, Lactose = false,FoodChallenge = false, Image = "~/Content/Images/Nectarine.png"},
                new BadFood {Id =13,Name = "Peach", Fructan = true, Sorbitol = true, Mannitol = false, Fructose = false, GOS = false, Lactose = false,FoodChallenge = false, Image = "~/Content/Images/Peach.png"},
                new BadFood {Id =14,Name = "Pear", Fructan = false, Sorbitol = true, Mannitol = false, Fructose = true, GOS = false, Lactose = false,FoodChallenge = false, Image = "~/Content/Images/Pear.png"},
                new BadFood {Id =15,Name = "Plum", Fructan = true, Sorbitol = true, Mannitol = false, Fructose = false, GOS = false, Lactose = false,FoodChallenge = false, Image = "~/Content/Images/Plum.png"},
                new BadFood {Id =16,Name = "Prune", Fructan = true, Sorbitol = true, Mannitol = false, Fructose = false, GOS = false, Lactose = false,FoodChallenge = false, Image = "~/Content/Images/Prune.png"},
                new BadFood {Id =17,Name = "Pomegranate", Fructan = true, Sorbitol = false, Mannitol = false, Fructose = false, GOS = false, Lactose = false,FoodChallenge = true, Image = "~/Content/Images/Pomegranate.png"},
                new BadFood {Id =18,Name = "Watermelon", Fructan = true, Sorbitol = false, Mannitol = true, Fructose = true, GOS = false, Lactose = false,FoodChallenge = false, Image = "~/Content/Images/Watermelon.png"},
                new BadFood {Id =19,Name = "Amaranth", Fructan = true, Sorbitol = false, Mannitol = false, Fructose = false, GOS = false, Lactose = false,FoodChallenge = true, Image = "~/Content/Images/Amaranth.png"},
                new BadFood {Id =20,Name = "Barley", Fructan = true, Sorbitol = false, Mannitol = false, Fructose = false, GOS = false, Lactose = false,FoodChallenge = true, Image = "~/Content/Images/Barley.png"},
                new BadFood {Id =21,Name = "Rye", Fructan = true, Sorbitol = false, Mannitol = false, Fructose = false, GOS = false, Lactose = false,FoodChallenge = true, Image = "~/Content/Images/Rye.png"},
                new BadFood {Id =22,Name = "Wheat", Fructan = true, Sorbitol = false, Mannitol = false, Fructose = false, GOS = false, Lactose = false,FoodChallenge = true, Image = "~/Content/Images/Wheat.png"},
                new BadFood {Id =23,Name = "Cashew", Fructan = false, Sorbitol = false, Mannitol = false, Fructose = false, GOS = true, Lactose = false,FoodChallenge = true, Image = "~/Content/Images/Cashew.png"},
                new BadFood {Id =24,Name = "Pistachio", Fructan = false, Sorbitol = false, Mannitol = false, Fructose = false, GOS = true, Lactose = false,FoodChallenge = true, Image = "~/Content/Images/Pistachio.png"},
                new BadFood {Id =25,Name = "Custard", Fructan = false, Sorbitol = false, Mannitol = false, Fructose = false, GOS = false, Lactose = true,FoodChallenge = true, Image = "~/Content/Images/Custard.png"},
                new BadFood {Id =26,Name = "Ice-Cream", Fructan = false, Sorbitol = false, Mannitol = false, Fructose = false, GOS = false, Lactose = true,FoodChallenge = true, Image = "~/Content/Images/IceCream.png"},
                new BadFood {Id =27,Name = "Milk", Fructan = false, Sorbitol = false, Mannitol = false, Fructose = false, GOS = false, Lactose = true,FoodChallenge = true, Image = "~/Content/Images/Milk.png"},
                new BadFood {Id =28,Name = "Yogurt", Fructan = false, Sorbitol = false, Mannitol = false, Fructose = false, GOS = false, Lactose = true,FoodChallenge = true, Image = "~/Content/Images/Yoghurt.png"},
                new BadFood {Id =29,Name = "Honey", Fructan = false, Sorbitol= false, Mannitol = false, Fructose = true, GOS = false, Lactose = false,FoodChallenge = true, Image = "~/Content/Images/Honey.png"},
                new BadFood {Id =30,Name = "Oligofructose", Fructan = true, Sorbitol = false, Mannitol = false, Fructose = false, GOS = false, Lactose = false,FoodChallenge = true, Image = "~/Content/Images/Oligofructose.png"},
                new BadFood {Id =31,Name = "Inulin", Fructan = true, Sorbitol = false, Mannitol = false, Fructose = false, GOS = false, Lactose = false,FoodChallenge = true, Image = "~/Content/Images/Inulin.png"},
                new BadFood {Id =32,Name = "FOS", Fructan = true, Sorbitol = false, Mannitol = false, Fructose = false, GOS = false, Lactose = false,FoodChallenge = true, Image = "~/Content/Images/FOS.png"},
                new BadFood {Id =33,Name = "Dandelion Tea", Fructan = true, Sorbitol = false, Mannitol = false, Fructose = false, GOS = false, Lactose = false,FoodChallenge = true, Image = "~/Content/Images/DandelionTea.png"},
                new BadFood {Id =34,Name = "Sugar-Free Chewing Gum", Fructan = false, Sorbitol = true, Mannitol = true, Fructose = false, GOS = false, Lactose = false,FoodChallenge = false, Image = "~/Content/Images/SugarFree.png"},
                new BadFood {Id =35,Name = "Artichoke Hearts", Fructan = false, Sorbitol = false, Mannitol = false, Fructose = true, GOS = false, Lactose = false,FoodChallenge = true, Image = "~/Content/Images/Artichoke.png"},
                new BadFood {Id =36,Name = "Asparagus", Fructan = true, Sorbitol = false, Mannitol = false, Fructose = true, GOS = false, Lactose = false,FoodChallenge = false, Image = "~/Content/Images/Asparagus.png"},
                new BadFood {Id =37,Name = "Avocado", Fructan = false, Sorbitol = true, Mannitol = false, Fructose = false, GOS = false, Lactose = false,FoodChallenge = true, Image = "~/Content/Images/Avocado.png"},
                new BadFood {Id =38,Name = "Beetroot", Fructan = true, Sorbitol = false, Mannitol = false, Fructose = false, GOS = false, Lactose = false,FoodChallenge = true, Image = "~/Content/Images/Beetroot.png"},
                new BadFood {Id =39,Name = "Broccoli", Fructan = false, Sorbitol = true, Mannitol = false, Fructose = false, GOS = false, Lactose = false,FoodChallenge = true, Image = "~/Content/Images/Broccoli.png"},
                new BadFood {Id =40,Name = "Brussel Sprouts", Fructan = true, Sorbitol = false, Mannitol = false, Fructose = false, GOS = false, Lactose = false,FoodChallenge = true, Image = "~/Content/Images/BrusselSprouts.png"},
                new BadFood {Id =41,Name = "Butternut Squash", Fructan = false, Sorbitol = false, Mannitol = true, Fructose = false, GOS = true, Lactose = false,FoodChallenge = false, Image = "~/Content/Images/ButternutSquash.png"},
                new BadFood {Id =42,Name = "Cauliflower", Fructan = false, Sorbitol = false, Mannitol = true, Fructose = false, GOS = false, Lactose = false,FoodChallenge = true, Image = "~/Content/Images/Cauliflower.png"},
                new BadFood {Id =43,Name = "Celery", Fructan = false, Sorbitol = false, Mannitol = true, Fructose = false, GOS = false, Lactose = false,FoodChallenge = true, Image = "~/Content/Images/Celery.png"},
                new BadFood {Id =44,Name = "Chicory Root", Fructan = true, Sorbitol = false, Mannitol = false, Fructose = false, GOS = false, Lactose = false,FoodChallenge = true, Image = "~/Content/Images/ChicoryRoot.png"},
                new BadFood {Id =45,Name = "Fennel Bulb", Fructan = true, Sorbitol = false, Mannitol = true, Fructose = false, GOS = false, Lactose = false,FoodChallenge = false, Image = "~/Content/Images/FennelBulb.png"},
                new BadFood {Id =46,Name = "Garlic", Fructan = true, Sorbitol = false, Mannitol = false, Fructose = false, GOS = false, Lactose = false,FoodChallenge = true, Image = "~/Content/Images/Garlic.png"},
                new BadFood {Id =47,Name = "Globe Artichoke", Fructan = true, Sorbitol = false, Mannitol = false, Fructose = false, GOS = false, Lactose = false,FoodChallenge = true, Image = "~/Content/Images/GlobeArtichoke.png"},
                new BadFood {Id =48,Name = "Jerusalem Artichoke", Fructan = true, Sorbitol = false, Mannitol = false, Fructose = true, GOS = false, Lactose = false,FoodChallenge = false, Image = "~/Content/Images/JerusalemArtichoke.png"},
                new BadFood {Id =49,Name = "Leek", Fructan = true, Sorbitol = false, Mannitol = false, Fructose = false, GOS = false, Lactose = false,FoodChallenge = true, Image = "~/Content/Images/Leek.png"},
                new BadFood {Id =50,Name = "Mangetout", Fructan = true, Sorbitol = false, Mannitol = true, Fructose = false, GOS = true, Lactose = false,FoodChallenge = false, Image = "~/Content/Images/Mangetout.png"},
                new BadFood {Id =51,Name = "Okra", Fructan = true, Sorbitol = false, Mannitol = false, Fructose = false, GOS = false, Lactose = false,FoodChallenge = true, Image = "~/Content/Images/Okra.png"},
                new BadFood {Id =52,Name = "Onion", Fructan = true, Sorbitol = false, Mannitol = false, Fructose = false, GOS = false, Lactose = false,FoodChallenge = true, Image = "~/Content/Images/Onion.png"},
                new BadFood {Id =53,Name = "Spring Onion", Fructan = true, Sorbitol = false, Mannitol = false, Fructose = false, GOS = false, Lactose = false,FoodChallenge = true, Image = "~/Convent/Images/SpringOnion.png"},
                new BadFood {Id =54,Name = "Peas", Fructan = false, Sorbitol = false, Mannitol = false, Fructose = false, GOS = true, Lactose = false,FoodChallenge = true, Image = "~/Content/Images/Peas.png"},
                new BadFood {Id =55,Name = "Beans", Fructan = false, Sorbitol = false, Mannitol = false, Fructose = false, GOS = true, Lactose = false,FoodChallenge = true, Image = "~/Content/Images/Beans.png"},
                new BadFood {Id =56,Name = "Pulses", Fructan = false, Sorbitol = false, Mannitol = false, Fructose = false, GOS = true, Lactose = false,FoodChallenge = true, Image = "~/Content/Images/Pulses.png"},
                new BadFood {Id =57,Name = "Savoy Cabbage", Fructan = true, Sorbitol = false, Mannitol = false, Fructose = false, GOS = false, Lactose = false,FoodChallenge = true, Image = "~/Content/Images/SavoyCabbage.png"},
                new BadFood {Id =58,Name = "Sugar Snaps", Fructan = false, Sorbitol = false, Mannitol = false, Fructose = false, GOS = true, Lactose = false,FoodChallenge = true, Image = "~/Content/Images/SugarSnaps.png"},
                new BadFood {Id =59,Name = "Sweet Potato", Fructan = false, Sorbitol = false, Mannitol = true, Fructose = false, GOS = false, Lactose = false,FoodChallenge = true, Image = "~/Content/Images/SweetPotato.png"},
                new BadFood {Id =60,Name = "Sweetcorn", Fructan = false, Sorbitol = true, Mannitol = false, Fructose = false, GOS = true, Lactose = false,FoodChallenge = false, Image = "~/Content/Images/SweetCorn.png"},
            };
            base.Seed(context);

            foreach (var item in BadFood)
            {
                context.BadFoods.Add(item);
            }
            context.SaveChanges();


            // List<Symptoms> Reaction = new List<Symptoms>
                         
            //{
            //    new Symptoms {Id = 1, Bloating = true},
            //    new Symptoms {Id = 2, Constipation = true},
            //    new Symptoms {Id = 3, Diarrhoea = true}
            //};
            // foreach (var s in Reaction)
            // {
            //     context.Symptoms.Add(s);
            // }
           
            // context.SaveChanges();
        }
    }
}