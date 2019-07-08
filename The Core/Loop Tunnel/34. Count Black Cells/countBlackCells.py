def countBlackCells(n, m):
    return n + m + gcd(n,m) - 2

def gcd(a, b):
    if(b == 0):
        return a
    else:
        return gcd(b, a%b)
