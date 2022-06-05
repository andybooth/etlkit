namespace EtlKit;

public class DecisionTable<TModel>
{
    public DecisionTable<TModel> AddCondition<TProperty>(string name, Func<TModel, TProperty, bool> condition)
    {
        return this;
    }

    public DecisionTable<TModel> AddAction<TProperty>(string name, Action<TModel, TProperty> action)
    {
        return this;
    }    
}