using System;
 
namespace SilpoBonusCore
{
    public abstract class Offer
    {
        
        DateTime expirationDate;

        public Offer(DateTime expirationDate){
            this.expirationDate = expirationDate;
        }

        public abstract void Apply(Check check); 

        public bool isExpired(){
            return expirationDate >= DateTime.Now;
        }

    }
}