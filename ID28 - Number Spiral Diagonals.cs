long ans = 1; 
long topright; 
long step; 
long topleft;
long bottomleft;
long bottomright;
for (long i = 3; i<1002;i+=2)
{
    topright = i*i; 
    step = i-1; 
    topleft = topright-step; 
    bottomleft = topleft-step; 
    bottomright = bottomleft-step; 
    ans += topright+topleft+bottomleft+bottomright;
}
Console.Write(ans);

