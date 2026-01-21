using System;
using System.Collections.Generic;

class MergeSortUtility{
	public static List<Student> MergeSort(List<Student> list){
		if(list.Count<=1) return list;
		int mid= list.Count/2;
		
		List<Student> left= list.GetRange(0, mid);
		List<Student> right= list.GetRange(mid, list.Count-mid);
		
		left= MergeSort(left);
		right= MergeSort(right);
		return Merge(left, right);
	}
	static List<Student> Merge(List<Student> left, List<Student> right){
		List<Student> result= new List<Student>();
		int i=0, j=0;
		while(i<left.Count && j<right.Count){
			if(left[i].Marks >= right[j].Marks){
				result.Add(left[i]);
				i++;
			}else{
				result.Add(right[j]);
				j++;
			}
		}
		while(i<left.Count){
			result.Add(left[i]);
			i++;
		}
		while(j<right.Count){
			result.Add(right[j]);
			j++;
		}
		return result;
	}
}
