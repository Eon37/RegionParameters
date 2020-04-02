namespace lab4
{
    ///<summary>
    ///Factory to create the region of Germany
    ///</summary>
    class CreateGermany : CreateRegion
    {
        ///<summary>
        ///Creates a region of Germany
        ///</summary>
        ///<returns>
        ///Parameters for Germany
        ///</returns>
        public override IRegParams createReg()
        {
            return new De();
        }
    }
}