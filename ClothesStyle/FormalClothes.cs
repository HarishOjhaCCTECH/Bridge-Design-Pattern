using FashionStore.ClothesCategory;

namespace FashionStore.ClothesStyles
{
    class FormalClothes:ClothesStyle
    {
        public FormalClothes(IClothesCategory a) : base(a) { }

        public override string Display()
        {
            return "formal clothes found in :" + _clothesCat.FindClothes() + "\n";
        }
    }
}
