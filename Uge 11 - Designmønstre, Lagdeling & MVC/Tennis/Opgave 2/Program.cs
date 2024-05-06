// Først skal vi definere en interface til tilmeldingsformularer:
public interface IRegistrationForm
{
    void Display();
}

// Vi laver nu en klasse, der implementerer interfacet og repræsenterer tilmeldingsformularerne til enkeltspil for mænd:
public class MenSinglesRegistrationForm : IRegistrationForm
{
    public void Display()
    {
        Console.WriteLine("Men's singles registration form displayed.");
    }
}

// Vi laver en klasse mere, der implementerer interfacet og repræsenterer tilmeldingsformularerne til damedouble:
public class WomenDoublesRegistrationForm : IRegistrationForm
{
    public void Display()
    {
        Console.WriteLine("Women's doubles registration form displayed.");
    }
}

// Vi skaber så en abstract factory, der kan producere disse formularer:
public abstract class RegistrationFormFactory
{
    public abstract IRegistrationForm CreateRegistrationForm();
}

// Vi laver nu en klasse, der repræsenterer factory'en for enkeltspil for mænd:
public class MenSinglesRegistrationFormFactory : RegistrationFormFactory
{
    public override IRegistrationForm CreateRegistrationForm()
    {
        return new MenSinglesRegistrationForm();
    }
}

// Vi laver en klasse mere, der repræsenterer factory'en for damedouble:
public class WomenDoublesRegistrationFormFactory : RegistrationFormFactory
{
    public override IRegistrationForm CreateRegistrationForm()
    {
        return new WomenDoublesRegistrationForm();
    }
}