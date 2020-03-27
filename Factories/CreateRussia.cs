namespace lab4
{
    class CreateRussia : CreateRegion
    {
        public override IRegParams createReg()
        {
            return new Ru();
        }
    }
}