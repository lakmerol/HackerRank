static string catAndMouse(int x, int y, int z)
{
    int CatAdis = Math.Abs(z - x);
    int CatBdis = Math.Abs(z - y);
    if (CatAdis > CatBdis) return "Cat B";
    if (CatAdis < CatBdis) return "Cat A";
    return "Mouse C";
}