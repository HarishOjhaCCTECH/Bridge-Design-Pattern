using FashionStore.ClothesCategory;
using FashionStore.ClothesStyles;
namespace FashionStore
{
    
    class Program
    {
        static void Main(string[] args)
        {

            ClothesStyle ladiesJeans;
            ladiesJeans = new CasualClothes(new WomenCategory());
            Console.WriteLine(ladiesJeans.Display());

            ClothesStyle mensShirt;
            mensShirt = new FormalClothes(new MenCategory());
            Console.WriteLine(mensShirt.Display());

            ClothesStyle kidsPajama;
            kidsPajama = new CasualClothes(new KidCategory());
            Console.WriteLine(kidsPajama.Display());
        }
    }
}