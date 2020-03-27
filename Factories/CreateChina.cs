namespace lab4
{
    class CreateChina : CreateRegion
    {
        public override IRegParams createReg()
        {
            return new Cn();
        }
    }
}