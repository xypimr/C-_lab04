using task02;

namespace task03;

public class CarCatalog
{
    public Car[]? catalog { get; set; }
    public short? searchspeed { get; set; }
    public short? searchyear { get; set; }

    public string? mode { get; set; }

    public IEnumerator<Car> GetEnumerator()
    {
        if (catalog != null)
            switch (mode)
            {
                case "reverse":
                {
                    for (int i = catalog.Length - 1; i >= 0; i--)
                    {
                        yield return catalog[i];
                    }

                    break;
                }
                case "speedsearch":
                {
                    for (int i = 0; i < catalog.Length; i++)
                    {
                        if (catalog[i].MaxSpeed >= searchspeed)
                        {
                            yield return catalog[i];
                        }
                    }

                    break;
                }
                case "yearsearch":
                {
                    for (int i = 0; i < catalog.Length; i++)
                    {
                        if (catalog[i].ProductionYear <= searchyear)
                        {
                            yield return catalog[i];
                        }
                    }

                    break;
                }
                default:
                {
                    for (int i = 0; i < catalog.Length; i++)
                    {
                        yield return catalog[i];
                    }

                    break;
                }
            }
    }
}