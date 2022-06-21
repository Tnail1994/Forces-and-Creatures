using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICardPlacementBehaviour 
{
   public abstract void OnClick(CardObject cardObject);
   public abstract void OnHighlight(CardObject cardObject);
   public abstract void OnRemoveHighlight(CardObject cardObject);
}
