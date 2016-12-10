using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareGamesFarid
{
    public class StateDataContext : DataContext
    {
        public static string DBConnectionString = @"isostore:/Databases.sdf";
        public StateDataContext(string connectionString)
            : base(connectionString)
        { }


        public Table<State> State
        {
            get
            {
                return this.GetTable<State>();
            }
        }

        public void AddState(int a, int b,int c, int d,int e, int f,int g, int h,int i, int j,int k, int l,int m, int n,int o, int space,int move)
        {
            using (StateDataContext context = new StateDataContext(StateDataContext.DBConnectionString))
            {
                State s = new State();
                s.a = a;
                s.b = b;
                s.c = c;
                s.d = d;
                s.e = e;
                s.f = f;
                s.g = g;
                s.h = h;
                s.i = i;
                s.j = j;
                s.k = k;
                s.l = l;
                s.m = m;
                s.n = n;
                s.o = o;
                s.space = space;
                s.move = move;
                context.State.InsertOnSubmit(s);
                context.SubmitChanges();
            }
        }

        public IList<State> GetAllStates()
        {
            IList<State> list = null;
            using (StateDataContext context = new StateDataContext(StateDataContext.DBConnectionString))
            {
                IQueryable<State> query = from c in context.State select c;
                list = query.ToList();
            }
            return list;
        }

        public List<Stt> getStates()
        {
            IList<State> usrs = this.GetAllStates();
            List<Stt> allState = new List<Stt>();
            foreach (State m in usrs)
            {
                Stt s = new Stt();
                s.id = m.ID;
                s.a = m.a;
                s.b = m.b;
                s.c = m.c;
                s.d = m.d;
                s.e = m.e;
                s.f = m.f;
                s.g = m.g;
                s.h = m.h;
                s.i = m.i;
                s.j = m.j;
                s.k = m.k;
                s.l = m.l;
                s.m = m.m;
                s.n = m.n;
                s.o = m.o;
                s.space = m.space;
                s.move = m.move;
                allState.Add(s);
            }
            return allState;
        }


        public Stt getFirstState()
        {
            List<Stt> allState = getStates();
            return allState[0];
        }


        public void UpdateState(int id, int a, int b, int c, int d, int e, int f, int g, int h, int i, int j, int k, int l, int m, int n, int o, int space, int move)
        {
            using (StateDataContext context = new StateDataContext(StateDataContext.DBConnectionString))
            {
                IQueryable<State> entityQuery = from y in context.State where y.ID == id select y;
                State s = entityQuery.FirstOrDefault();
                s.a = a;
                s.b = b;
                s.c = c;
                s.d = d;
                s.e = e;
                s.f = f;
                s.g = g;
                s.h = h;
                s.i = i;
                s.j = j;
                s.k = k;
                s.l = l;
                s.m = m;
                s.n = n;
                s.o = o;
                s.space = space;
                s.move = move;
                context.SubmitChanges();
            }
        }


        public void UpdateStateA(int id, int v, int n ,int space, int move)
        {
            using (StateDataContext context = new StateDataContext(StateDataContext.DBConnectionString))
            {
                IQueryable<State> entityQuery = from c in context.State where c.ID == id select c;
                State s = entityQuery.FirstOrDefault();
                if (n==1)
                    s.a = v;
                if (n == 2)
                s.b = v;
                if (n == 3)
                    s.c = v;
                if (n == 4)
                    s.d = v;
                if (n == 5)
                    s.e = v;
                if (n == 6)
                    s.f = v;
                if (n == 7)
                    s.g = v;
                if (n == 8)
                    s.h = v;
                if (n == 9)
                    s.i = v;
                if (n == 10)
                    s.j = v;
                if (n == 11)
                    s.k = v;
                if (n == 12)
                    s.l = v;
                if (n == 13)
                    s.m = v;
                if (n == 14)
                    s.n = v;
                if (n == 15)
                    s.o = v;
                s.space = space;
                s.move = move;
                context.SubmitChanges();
            }
        }

    }
}
