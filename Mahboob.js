<div>
    Counted Value : <span id="counter">{state.counter}</span>
</div>
<button id="inc"> + </button>
<button id="dec"> - </button>
<script>
	var count = {
	    counter: 3,
	    id: new date()
	}
	document.querySelector("#inc").onclick = () => dispatch('INC')
	document.querySelector("#dec").onclick = () => dispatch('DEC')
	function dispatch(action) {
		const newState = reducer(state, action)

		if ( newState !== state) {
			state = newState
		}

		listeners.forEach(listener => listener())
	}

	const listeners = []

	function subscribe(callBack) {
		listeners.push(callBack)
	}
	function reducer(state = count, action) {
		switch (action) {
			case 'INC':
				return {
					...state,
					counter : state.counter + 1
				}
			case 'DEC':
				return {
					...state,
					counter : state.counter - 1
				}
			default:
				return state
		}
	}
	subscribe(updateView)
	function updateView() {
		document.querySelector("#counter").innerText = state.counter
	}

</script>


    const years = [];
    let theYear = -1;
    for (let i = 0; i < data.length; i++) {
        for (let j = 0; j < data[i].children.length; j++) {
            for (let k = 0; k < data[i].children[j].values.length; k++) {
                theYear = data[i].children[j].values[k].year;
                if (years.indexOf(theYear) < 0) {
                    years.push(theYear);
                }
            }
        }
    }
    // sort in descending order
    years.sort((a, b) => {
        return (b - a);
    });
    return years;
