/**
Determines if the given 2D array represents a valid Sudoku solution.
@param {Array<Array<number>>} solution - The Sudoku solution to be validated.
@returns {boolean} - True if the solution is valid, false otherwise.
*/

function validSolution(solution) {
    // Check for repeated values in the row or column.
    for (let i = 0; i < 9; i++) {
        const row = new Set();
        const col = new Set();

        for (let j = 0; j < 9; j++) {
            if (solution[i][j] === 0 || row.has(solution[i][j])) {
                return false;
            }

            if (solution[j][i] === 0 || col.has(solution[j][i])) {
                return false;
            }

            // Add values to the row and column Sets.
            row.add(solution[i][j]);
            col.add(solution[j][i]);
        }
    }

    // Check for repeated values in the 3*3 squares
    for (let i = 0; i < 9; i += 3) {
        for (let j = 0; j < 9; j += 3) {
            const square = new Set();

            for (let k = 0; k < 3; k++) {
                for (let l = 0; l < 3; l++) {
                    const value = solution[i + k][j + l];

                    if (value === 0 || square.has(value)) {
                        return false;
                    }

                    // Add values to the square Set.
                    square.add(value);
                }
            }
        }
    }

    // If all checks pass, the solution is valid.
    return true;
}

