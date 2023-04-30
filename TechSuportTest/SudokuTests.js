function validSolution(solution) {
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

            row.add(solution[i][j]);
            col.add(solution[j][i]);
        }
    }


    for (let i = 0; i < 9; i += 3) {
        for (let j = 0; j < 9; j += 3) {
            const square = new Set();

            for (let k = 0; k < 3; k++) {
                for (let l = 0; l < 3; l++) {
                    const value = solution[i + k][j + l];

                    if (value === 0 || square.has(value)) {
                        return false;
                    }

                    square.add(value);
                }
            }
        }
    }

    return true;
}