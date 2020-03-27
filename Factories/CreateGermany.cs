namespace lab4
{
    class CreateGermany : CreateRegion
    {
        public override IRegParams createReg()
        {
            return new De();
        }
    }
}