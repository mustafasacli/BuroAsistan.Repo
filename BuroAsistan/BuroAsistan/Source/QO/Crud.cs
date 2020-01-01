namespace BuroAsistan.Source.QO
{
    /* Query Object Class */
    internal class Crud
    {

        internal static string GetPersonList()
        {
            return @"SELECT P.*,Pr.ProcurationId FROM Person P
                    LEFT JOIN PersonProcurations PP ON P.OBJID=PP.PersonId
                    LEFT JOIN Procurations Pr ON PP.ProcurationId=Pr.OBJID";
        }

        internal static string GetPersonByActivation()
        {
            return @"SELECT P.*,Pr.ProcurationId FROM Person P
                    LEFT JOIN PersonProcurations PP ON P.OBJID=PP.PersonId
                    LEFT JOIN Procurations Pr ON PP.ProcurationId=Pr.OBJID
                    WHERE P.IsActive=1";
        }

    }
}
