using FirstUnique;

namespace SolutionTests
{
    public class SolutionUnitTests
    {
        [Theory]
        [InlineData(new int[] { 4, 10, 5, 4, 2, 10 }, 5)]
        [InlineData(new int[] { 1, 4, 3, 3, 1, 2 }, 4)]
        [InlineData(new int[] { 6, 4, 4, 6 }, -1)]
        public void GivenArray_WhenSolutionCalled_ThenReturnsFirstUniqueInteger(int[] input, int expected)
        {
            Solution sol = new Solution();
            int actual = sol.solution(input);
            Assert.Equal(expected, actual);
        }
    }
}
