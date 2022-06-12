using UnityEngine;

public class ManaSpender 
{
    public void CastSpell(Transform caster, int manaCost)
    {
        SpendMana(caster, manaCost);
    }

    public void SummonCreature(Transform summoner, int manaCost)
    {
        SpendMana(summoner, manaCost);
    }

    private void SpendMana(Transform manaSpender, int manaCost)
    {
        var manaUser = manaSpender.GetComponent<IMasaUseService>();

        if (manaUser == null) return;

        manaUser.SpendMana(manaCost);

        Debug.Log($"User {manaUser.Name} has Mana {manaUser.Mana} left.");
        Debug.Log($"User {manaUser.Name} has Mana in Manafield {manaUser.ManaField} left.");
    }
}
