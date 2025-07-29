namespace console_field_keyword.Entities;

public class User
{
    public required string Name
    {
        get;
        set => field = value is null ? throw new ArgumentNullException(nameof(value), $"A propriedade '{nameof(Name)}' é obrigatória.") :
                       value.Length < 3 ? throw new ArgumentException($"A propriedade '{nameof(Name)}' deve conter pelo menos 3 caracteres.", nameof(value)) : value;
    }

    public int Age
    {
        get;
        set => field = value < 18 ? throw new ArgumentOutOfRangeException(nameof(value), $"A propriedade '{nameof(Age)}' deve ser maior ou igual a 18.") : value;
    }

    public override string ToString() =>
        $"Nome: {Name}, Idade: {Age}";
}
