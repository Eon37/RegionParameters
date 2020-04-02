namespace lab4
{
    ///<summary>
    ///Factory to create the region of China
    ///</summary>
    class CreateChina : CreateRegion
    {
        ///<summary>
        ///Creates a region of China
        ///</summary>
        ///<returns>
        ///Parameters for China
        ///</returns>
        public override IRegParams createReg()
        {
            return new Cn();
        }
    }
}