namespace lab4
{
    ///<summary>
    ///Factory to create the region of Russia
    ///</summary>
    class CreateRussia : CreateRegion
    {
        ///<summary>
        ///Creates a region of Russia
        ///</summary>
        ///<returns>
        ///Parameters for Russia
        ///</returns>
        public override IRegParams createReg()
        {
            return new Ru();
        }
    }
}