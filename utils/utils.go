package utils

func Contains[T string | int](array []T, value T) bool {
	for _, v := range array {
		if v == value {
			return true
		}
	}

	return false
}
