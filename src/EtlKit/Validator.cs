namespace EtlKit;

public class Validator<TModel>
{
    private List<Func<TModel, bool>> _rules = new();

    public Validator<TModel> AddRule(Func<TModel, bool> rule)
    {
        _rules.Add(rule);
        return this;
    }

    public bool IsValid(TModel model) => _rules.All(r => r(model));
}
