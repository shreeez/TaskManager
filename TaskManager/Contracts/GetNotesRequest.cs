namespace TaskManager.Contracts;

public record GetNotesRequest(string? Search, string? SortItem, string? SortOrder);