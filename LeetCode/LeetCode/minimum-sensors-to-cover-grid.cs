namespace LeetCode;

public class minimum_sensors_to_cover_grid
{
    public int MinSensors(int n, int m, int k) {
        int side = 2 * k + 1;
        return ((n - 1) / side + 1) * ((m - 1) / side + 1);
    }
}