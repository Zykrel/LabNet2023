using Lab.EF.Data;


namespace Lab.EF.Logic
{
    public class BaseLogic
    {
        protected readonly NorthWindContext _northwindcontext;

        public BaseLogic() 
        {
            _northwindcontext = new NorthWindContext();
        }
    }
}
