namespace lab4
{
    ///<summary>
    ///Factory to create concrete region
    ///</summary>
    abstract class CreateRegion
    {
        ///<summary>
        ///Creates parameters for a concrete region
        ///</summary>
        ///<returns>
        ///Parameters for a concrete region
        ///</returns>
        public abstract IRegParams createReg();

    }
}