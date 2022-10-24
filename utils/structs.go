package utils

type IPoint struct {
	strongly_agree    int
	agree             int
	disagree          int
	strongly_disagree int
}

type IQuestion struct {
	question string
	points   *IPoint
}

func Point(strongly_agree int, agree int, disagree int, strongly_disagree int) *IPoint {
	return &IPoint{
		strongly_agree:    strongly_agree,
		agree:             agree,
		disagree:          disagree,
		strongly_disagree: strongly_disagree,
	}
}
