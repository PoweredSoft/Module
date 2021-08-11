# Reasoning

Just makes it easier to organize modules with a class instead of a static extension method.


```csharp
services
	.AddModule<SomeModule>()
	.AddModule<SomeOtherModule>();
```

```csharp
public class MyModule : IModule 
{
	public IServiceCollection ConfigureServices(IServiceCollection services) 
	{
		services.AddModule<CoolOtherModule>();
		return services;
	}
}
```
