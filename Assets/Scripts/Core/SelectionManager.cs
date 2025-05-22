using System;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class SelectionManager<T> where T : IData
{
    private readonly IDataProvider<T> _provider;
    private readonly SelectionContainer<T> _container;
    private readonly List<ISelectionHandler<T>> _handlers;

    public SelectionManager(IDataProvider<T> provider, SelectionContainer<T> container)
    {
        _provider = provider;
        _container = container;
        _handlers = new List<ISelectionHandler<T>>();
    }

    public void RegisterHandler(ISelectionHandler<T> handler)
    {
        if (!_handlers.Contains(handler))
            _handlers.Add(handler);
    }

    public void Select(string id)
    {
        var data = _provider.GetAll().FirstOrDefault(d => d.Id == id);
        if (data == null) return;

        _container.SetSelection(data);
        foreach (var handler in _handlers)
        {
            handler.OnSelected(data);
        }
    }
}
