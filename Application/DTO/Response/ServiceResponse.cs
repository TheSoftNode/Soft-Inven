namespace Application.DTO.Response;

public record ServiceResponse(bool Flag, string Message)
{
	public bool HasError => !Flag;
}
