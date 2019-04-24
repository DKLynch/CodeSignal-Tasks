int[] metroCard(int lastNumberOfDays) {
    switch (lastNumberOfDays){
        case 28:
        case 30:
            return new int[]{31};
        case 31:
            return new int[]{28, 30, 31};
        default:
            return null;
    }
}
