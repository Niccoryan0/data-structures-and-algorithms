# Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.

def findMedianSortedArrays(self, nums1: List[int], nums2: List[int]) -> float:
    nums = sorted(nums1 + nums2)
    if len(nums) % 2 != 0:
        return nums[math.floor(len(nums)/2)]
    else:
        return (nums[math.floor(len(nums)/2)] + nums[math.floor(len(nums)/2)-1])/2