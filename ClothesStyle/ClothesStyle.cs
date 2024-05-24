using FashionStore.ClothesCategory;

namespace FashionStore.ClothesStyles
{
    class ClothesStyle
    {
        protected IClothesCategory _clothesCat;

        public ClothesStyle(IClothesCategory implementation)
        {
            this._clothesCat = implementation;
        }

        public virtual string Display()
        {
            return "clothes found:\n" + _clothesCat.FindClothes() + "\n";
        }
    }
}
