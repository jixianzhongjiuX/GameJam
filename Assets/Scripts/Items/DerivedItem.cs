
//������������
public class SingleEffectItem:Item
{
    public override void Do_Item_Function()
    {
        foreach (ItemFunction curr in itemFunctions) curr.Do_function(this);
        Destroy(gameObject);
    }
}

public class LongLastingItem : Item //����
{
    public override void Do_Item_Function()
    {
        foreach (ItemFunction curr in itemFunctions) curr.Do_function(this);
    }
}

public class RandomItem :Item
{

}

public class ChangeWithTimeItem :Item
{

}


