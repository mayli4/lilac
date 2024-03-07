namespace Lilac.Core {
    public abstract class Entity {

        List<object> components = new();

        public int ID { get; }

        public virtual void Update(in Entity entity) { }
        public virtual void Draw(in Entity entity) { }

        public static Entity CreateEntity(Vector2 pos) {
            var entityPos = new EntityPosition { Value = pos };
            return null;
        }

        public object Get<T>() where T : struct {
            foreach(var component in components) {
                if(typeof(T) == component.GetType())
                    return component;
                continue;
            }
            return null;
        }

    }
}
