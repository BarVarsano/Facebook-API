using System;

namespace FacebookPlayerLogics
{
    public interface IPlayerComponent
    {
        event Action<IPlayerComponent> OnComponentAdded;

        event Action<IPlayerComponent> OnComponentRemoved;

        string Name { get; }

        bool IsContains(IPlayerComponent i_Component);

        void AddComponent(IPlayerComponent i_ComponentToAdd);

        void RemoveComponent(IPlayerComponent i_ComponentToRemove);

        eSongMode Mode { get; set; }

        string URL { get; }
    }
}
