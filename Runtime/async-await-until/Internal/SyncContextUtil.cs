#if NET_4_6
using System.Threading;
using UnityEngine;

namespace BeatThat.AsyncAwaitUntil.UnityAsyncAwaitUtil
{
    public static class SyncContextUtil
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        static void Install()
        {
            UnitySynchronizationContext = SynchronizationContext.Current;
            UnityThreadId = Thread.CurrentThread.ManagedThreadId;
        }

        public static int UnityThreadId
        {
            get; private set;
        }

        public static SynchronizationContext UnitySynchronizationContext
        {
            get; private set;
        }
    }
}
#endif
