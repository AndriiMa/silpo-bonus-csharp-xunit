using System;
 
namespace SilpoBonusCore
{
    public abstract class Offer
    {
        
        DateTime expirationDate;

        public Offer(DateTime expirationDate){
            this.expirationDate = expirationDate;
        }

        public abstract void AddPoints(Check check); 

        public bool IsExpired(){
            return DateTime.Now <= expirationDate;
        }

        public void Apply(Check check){
                AddPoints(check);
        }
    }
}