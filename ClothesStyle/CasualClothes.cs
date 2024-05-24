using FashionStore.ClothesCategory;

namespace FashionStore.ClothesStyles
{
    class CasualClothes:ClothesStyle
    {
        public CasualClothes(IClothesCategory a) : base(a) { }

        public override string Display()
        {
            return "Casual clothes found in: " + _clothesCat.FindClothes() + "\n";
        }
    }
}
