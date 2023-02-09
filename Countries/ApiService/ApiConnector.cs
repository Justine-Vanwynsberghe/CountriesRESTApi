﻿using System.Net;
using System.Net.Http.Json;
using Countries.ApiService.Interfaces;

namespace Countries.ApiService;

public class ApiConnector<T> : IApiConnector<T>
{
    private readonly HttpClient _httpClient;

    public ApiConnector(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<T?> GetAsync(string requestUri)
    {
        var response = await _httpClient.GetAsync(requestUri);

        response.EnsureSuccessStatusCode();

        if (response.StatusCode == HttpStatusCode.NoContent) return default;

        var content = await response.Content.ReadFromJsonAsync<T>();
        return content;
    }

    public async Task<IList<T>?> FindAsync(string requestUri)
    {
        var response = await _httpClient.GetAsync(requestUri);

        response.EnsureSuccessStatusCode();

        if (response.StatusCode == HttpStatusCode.NoContent) return default;

        var content = await response.Content.ReadFromJsonAsync<IList<T>>();
        return content;
    }
}