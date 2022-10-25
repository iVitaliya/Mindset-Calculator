package main

import (
	"fmt"
	"strconv"

	// mcu "github.com/iVitaliya/Mindset-Calculator/utils"
	"github.com/iVitaliya/colors-go"
	"github.com/iVitaliya/logger-go"
	"github.com/iVitaliya/logger-go/utils"
	"github.com/iVitaliya/memory-go"
)

var (
	questions = []IQuestion{
		{
			question: "Your intelligence is something very basic about you that you can't change very much",
			points:   Point(0, 1, 2, 3),
		},
		{
			question: "No matter how much intelligence you have, you can always change it quite a bit",
			points:   Point(3, 2, 1, 0),
		},
	}
)

func FormatIntArgument(arg int, point *IPoint) int {
	var res int

	switch arg {
	case 1:
		res = point.strongly_agree

	case 2:
		res = point.agree

	case 3:
		res = point.disagree
	case 4:
		res = point.strongly_disagree
	}

	return res
}

func Ask(idx int, question IQuestion, collection *memory.ICollection[int]) {
	var (
		res string
		log = utils.FormatString("{0}{1}{2} {3} [1..4]\n{4} Strongly Agree\n{5} Agree\n{6} Disagree\n{7} Strongly Disagree", []string{
			colors.Gray("["),
			colors.Dim(colors.BrightYellow("?")),
			colors.Gray("]"),
			colors.White(question.question),
			colors.BrightBlue("1"),
			colors.BrightBlue("2"),
			colors.BrightBlue("3"),
			colors.BrightBlue("4"),
		})
	)

	fmt.Print(log)
	fmt.Scan(&res)

	number, err := strconv.Atoi(res)
	if err != nil {
		logger.Error(err.Error())
		return
	}

	if !Contains([]int{1, 2, 3, 4}, number) {
		logger.Error("Your answer may only be 1, 2, 3 or 4, you specified \"" + res + "\" instead, please try again!")
		Ask(idx, question, collection)
	}

	collection.Set("points", FormatIntArgument(number, question.points))
}

func main() {
	var collection *memory.ICollection[int] = memory.Collection[int]()

	// ASK QUESTION THEN REFORMAT TO POINT AND ADD IT TO THE COLLECTION
	for i := 0; i < len(questions); i++ {
		Ask(i, questions[i], collection)
	}

	logger.Debug(utils.FormatString("Points: {0}", []string{
		fmt.Sprint(collection.Get("points")),
	}))
}
