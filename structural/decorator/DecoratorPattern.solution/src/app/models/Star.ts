import { TreeDecorator } from './TreeDecorator';
import { IChristmasTree } from './IChristmasTree';

export class Star extends TreeDecorator {
    constructor(tree: IChristmasTree) {
        super(tree);
    }

    public decorate(): string[] {
        const tree = super.decorate();
        tree.push(this.decorateWithStar());
        return tree;
    }

    private decorateWithStar(): string {
        return 'star';
    }
}
