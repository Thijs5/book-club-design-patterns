import { TreeDecorator } from './TreeDecorator';
import { IChristmasTree } from './IChristmasTree';

export class Balls extends TreeDecorator {
    constructor(tree: IChristmasTree) {
        super(tree);
    }

    public decorate(): string[] {
        const tree = super.decorate();
        tree.push(this.decorateWithBalls());
        return tree;
    }

    private decorateWithBalls(): string {
        return 'balls';
    }
}
