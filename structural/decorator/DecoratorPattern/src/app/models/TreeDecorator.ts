import { IChristmasTree } from './IChristmasTree';

export abstract class TreeDecorator implements IChristmasTree {
    private tree: IChristmasTree;

    constructor(tree: IChristmasTree) {
        this.tree = tree;
    }

    public decorate(): string[] {
        return this.tree.decorate();
    }
}
