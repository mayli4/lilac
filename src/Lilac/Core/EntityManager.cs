namespace Lilac.Core {
    public class EntityManager {
        private static List<int> activeEntityIDs = new();
        private static List<int> inactiveEntityIDs = new();

        public static bool GetActive(int entity) {
            if(entity < 0 || entity > inactiveEntityIDs.Count)
                return false;
            
            return activeEntityIDs.Contains(entity);
        }
    }
}
